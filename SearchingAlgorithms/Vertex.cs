﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barte_SearchAlgo
{
    public class Vertex
    {
        public char ID;
        public int IDX;
        public Point Location;
        public int AccumulatedWeight;
        public double Heuristic;
        public List<Vertex> Ancestors = new List<Vertex>();

        public Vertex(char id, int idx, Point location)
        {
            this.Location = location;
            this.ID = id;
            this.IDX = idx;
            this.AccumulatedWeight = 0;
            this.Heuristic = 0;
        }

        public Vertex(Vertex v)
        {
            this.Location = v.Location;
            this.ID = v.ID;
            this.IDX = v.IDX;
        }

        public override string ToString()
        {
            return this.ID.ToString();
        }

        public bool Has(Vertex v)
        {
            if (Ancestors.Count == 0) return false;
            foreach (Vertex a in Ancestors)
            {
                if (a.ID == v.ID) return true;
            }
            return false;
        }

        public override bool Equals(object obj)
        {
            return (obj is Vertex a && a.ID == this.ID);
        }

        public override int GetHashCode()
        {
            return ID.GetHashCode();
        }
    }    
}
