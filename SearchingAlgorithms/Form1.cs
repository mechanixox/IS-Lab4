using System.Collections.Generic;
using System.Drawing;
using System;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Barte_SearchAlgo
{
    public partial class Form1 : Form
    {
        public string Logs = "";


        public bool AnimationPaused = false;
        public bool AnimationRunning = false;
        public List<Vertex> Vertices = new List<Vertex>();
        public List<Edge> Edges = new List<Edge>();
        public Graph Graph = new Graph();
        public List<Vertex> Path = new List<Vertex>();
        private int CurrentNodeIndex = 0;
        Vertex SearchVertex;
        Vertex StartVertex;
        Graphics g;
        
        private bool isPaused = true;
        char VertexLabel = 'A';
        int VertexIndex = 0;
        public Form1()
        {
            InitializeComponent();
            g = this.PictureBoxGraph.CreateGraphics();
        }
        private void PictureBoxGraph_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if (ComboBoxFrom.SelectedIndex == -1 || ComboBoxTo.SelectedIndex == -1 || string.IsNullOrWhiteSpace(TextBoxWeight.Text))
            {
                MessageBox.Show("Complete empty fields!");
                return;
            }
            if (!int.TryParse(TextBoxWeight.Text, out int weight))
            {
                MessageBox.Show("Input valid weight!");
                return;
            }
            if (ComboBoxFrom.SelectedIndex == ComboBoxTo.SelectedIndex)
            {
                MessageBox.Show("Choose another destination vertex!");
                return;
            }
            Vertex start = Vertices[ComboBoxFrom.SelectedIndex];
            Vertex end = Vertices[ComboBoxTo.SelectedIndex];
            Edges.Add(new Edge(start, end, weight));
            Font font = new Font("Arial", 10);

            float textX = (start.Location.X + end.Location.X) / 2;
            float textY = (start.Location.Y + end.Location.Y) / 2;

            g.DrawString(weight.ToString(), font, Brushes.Black, textX, textY);
            g.DrawLine(Pens.Black, start.Location, end.Location);
            PaintVertex();
        }

        private void ButtonFinalize_Click(object sender, EventArgs e)
        {
            if (Edges.Count == 0)
            {
                MessageBox.Show("Add at least one edge!");
                return;
            }
            ComboBoxFrom.Enabled = false;
            ComboBoxTo.Enabled = false;
            TextBoxWeight.Enabled = false;
            AddEdge.Enabled = false;
            AddVertex.Enabled = false;
            ButtonAdd.Enabled = false;

            LogBox.Enabled = true;
            ButtonBFS.Enabled = true;
            ButtonDFS.Enabled = true;
            ButtonAStar.Enabled = true;
            ButtonBeam.Enabled = true;
            ButtonBnB.Enabled = true;
            ButtonHC.Enabled = true;
            ComboBoxStart.Enabled = true;
            ComboBoxSearch.Enabled = true;
            ButtonRun.Enabled = true;
            TrackbarSpeed.Enabled = true;
            Graph.InitializeMatrix(Vertices.Count);
            Graph.UpdateMatrix(Edges);
        }

        private void ButtonRun_Click(object sender, EventArgs e)
        {
            if (ComboBoxStart.SelectedIndex == -1)
            {
                MessageBox.Show("Select a starting vertex!");
                return;
            }
            ButtonPause.Enabled = true;
            isPaused = false;

            SearchVertex = ComboBoxSearch.SelectedItem as Vertex;
            StartVertex = ComboBoxStart.SelectedItem as Vertex;

            if (ButtonBFS.Checked)
            {
                Path = Graph.BFS_order(Vertices, StartVertex, SearchVertex, Vertices.Count);
            }
            else if (ButtonDFS.Checked)
            {
                Path = Graph.DFS_order(Vertices, StartVertex, SearchVertex, Vertices.Count);

            }
            else if (ButtonBeam.Checked)
            {
                Path = Graph.Beam(Vertices, StartVertex, SearchVertex, Vertices.Count);
            }
            else if (ButtonHC.Checked)
            {
                Path = Graph.HillClimbing(Vertices, StartVertex, SearchVertex, Vertices.Count);
            }
            else if (ButtonBnB.Checked)
            {
                Path = Graph.BranchAndBound(Vertices, StartVertex, SearchVertex, Vertices.Count);
            }
            else if (ButtonAStar.Checked)
            {
                Path = Graph.AStar(Vertices, StartVertex, SearchVertex, Vertices.Count);
            }

            InitAnimation();
        }

        private void InitAnimation()
        {
            CurrentNodeIndex = 0;
            AnimationClock.Enabled = true;
            AnimationClock.Start();
            AnimationRunning = true;
            AnimationPaused = false;
        }
        private void ButtonPause_Click(object sender, EventArgs e)
        {
            if (isPaused)
            {
                AnimationClock.Start();
                isPaused = false;
                ButtonPause.Text = "Pause";
            }

            else
            {
                AnimationClock.Stop();
                isPaused = true;
                ButtonPause.Text = "Play";
            }
        }

        private void PaintVertex()
        {
            int diameter = 50;
            foreach (Vertex v in Vertices)
            {
                int x = v.Location.X - diameter / 2;
                int y = v.Location.Y - diameter / 2;

                int textX = v.Location.X - diameter / 8;
                int textY = v.Location.Y - diameter / 8;

                g.FillEllipse(Brushes.Black, x, y, diameter, diameter);
                g.DrawEllipse(Pens.White, x, y, diameter, diameter);
                g.DrawString(v.ID.ToString(), this.Font, Brushes.White, textX, textY);
            }
        }

        private void PaintEdges()
        {
            foreach (Edge edge in Edges)
            {
                float textX = (edge.From.Location.X + edge.To.Location.X) / 2;
                float textY = (edge.From.Location.Y + edge.To.Location.Y) / 2;

                g.DrawString(edge.Cost.ToString(), this.Font, Brushes.Black, textX, textY);
                g.DrawLine(Pens.Black, edge.From.Location, edge.To.Location);
            }
        }

        private void ButtonUndo_Click(object sender, EventArgs e)
        {
            if (Vertices.Count <= 0) return;

            Vertex VertexToRemove = Vertices[Vertices.Count - 1];

            List<Edge> EdgesToRemove = new List<Edge>();
            foreach (Edge edge in Edges)
            {
                if (edge.From.Equals(VertexToRemove) || edge.To.Equals(VertexToRemove))
                {
                    EdgesToRemove.Add(edge);
                }
            }
            foreach (Edge edge in EdgesToRemove)
            {
                Edges.Remove(edge);
            }

            Vertices.RemoveAt(Vertices.Count - 1);

            VertexLabel--;
            VertexIndex--;

            PictureBoxGraph.Image = null;
            RefreshSource();
            PictureBoxGraph.Update();
            PaintEdges();
            PaintVertex();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (Edges.Count <= 0) return;
            Edges.RemoveAt(Edges.Count - 1);

            // picture box update
            PictureBoxGraph.Image = null;
            RefreshSource();
            PictureBoxGraph.Update();
            PaintEdges();
            PaintVertex();
        }

        private void RefreshSource()
        {
            ComboBoxFrom.DataSource = null;
            ComboBoxTo.DataSource = null;
            ComboBoxStart.DataSource = null;
            ComboBoxSearch.DataSource = null;

            ComboBoxFrom.DataSource = new List<Vertex>(Vertices);
            ComboBoxTo.DataSource = new List<Vertex>(Vertices);
            ComboBoxStart.DataSource = Vertices;
            ComboBoxSearch.DataSource = new List<Vertex>(Vertices);
        }

        private void AnimationClock_Tick(object sender, EventArgs e)
        {
            if (CurrentNodeIndex >= Path.Count)
            {
                AnimationClock.Stop();
                AnimationRunning = false;
                MessageBox.Show("Searching finished!");
                return;
            }
            int diameter = 50;

            Vertex CurrentVertex = Path[CurrentNodeIndex];

            if (CurrentNodeIndex > 0)
            {

                Vertex PreviousVertex = Path[CurrentNodeIndex - 1];

                int xx = PreviousVertex.Location.X - diameter / 2;
                int yy = PreviousVertex.Location.Y - diameter / 2;
                int textXX = PreviousVertex.Location.X - diameter / 8;
                int textYY = PreviousVertex.Location.Y - diameter / 8;

                g.FillEllipse(Brushes.DarkGray, xx, yy, diameter, diameter);
                g.DrawEllipse(Pens.White, xx, yy, diameter, diameter);
                g.DrawString(PreviousVertex.ID.ToString(), this.Font, Brushes.White, textXX, textYY);
            }

            int x = CurrentVertex.Location.X - diameter / 2;
            int y = CurrentVertex.Location.Y - diameter / 2;

            int textX = CurrentVertex.Location.X - diameter / 8;
            int textY = CurrentVertex.Location.Y - diameter / 8;

            g.FillEllipse(Brushes.Red, x, y, diameter, diameter);
            g.DrawEllipse(Pens.White, x, y, diameter, diameter);
            g.DrawString(CurrentVertex.ID.ToString(), this.Font, Brushes.White, textX, textY);

            if (CurrentVertex.Equals(SearchVertex))
            {
                g.FillEllipse(Brushes.Blue, x, y, diameter, diameter);
                g.DrawEllipse(Pens.White, x, y, diameter, diameter);
                g.DrawString(CurrentVertex.ID.ToString(), this.Font, Brushes.White, textX, textY);

            }
            Logs += ($"{CurrentVertex.Heuristic} + {CurrentVertex.AccumulatedWeight} = {CurrentVertex.Heuristic + CurrentVertex.AccumulatedWeight}\n");
            CurrentNodeIndex++;
        }

        private void PictureBoxGraph_Click(object sender, EventArgs e)
        {

        }

        private void PictureBoxGraph_MouseClick_1(object sender, MouseEventArgs e)
        {
            if (!AddVertex.Checked) return;
            Point clickPoint = e.Location;
            Vertices.Add(new Vertex(VertexLabel, VertexIndex, e.Location));

            int diameter = 50;
            int x = clickPoint.X - diameter / 2;
            int y = clickPoint.Y - diameter / 2;
            int textX = e.X - diameter / 8;
            int textY = e.Y - diameter / 8;

            g.FillEllipse(Brushes.Black, x, y, diameter, diameter);
            g.DrawEllipse(Pens.Black, x, y, diameter, diameter);
            g.DrawString(VertexLabel.ToString(), this.Font, Brushes.White, textX, textY);

            RefreshSource();

            VertexLabel++;
            VertexIndex++;
        }
        private void AddEdge_CheckedChanged(object sender, EventArgs e)
        {  
            if (AddEdge.Checked)
            {
                ComboBoxFrom.Enabled = true;
                ComboBoxTo.Enabled = true;
                TextBoxWeight.Enabled = true;
            }
            else
            {
                ComboBoxFrom.Enabled = false;
                ComboBoxTo.Enabled = false;
                TextBoxWeight.Enabled = false;
            }
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            Form form = (Form)sender;
            PictureBox pictureBox = form.Controls.OfType<PictureBox>().FirstOrDefault();

            if (pictureBox != null)
            {
                pictureBox.Invalidate();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void ButtonBFS_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void TrackbarSpeed_Scroll(object sender, EventArgs e)
        {

        }

        private void ButtonStepForward_Click(object sender, EventArgs e)
        {

        }

        private void AddVertex_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}