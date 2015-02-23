using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace projettaquin
{
    // classe abstraite, il est donc impératif de créer une classe qui en hérite
    // pour résoudre un problème particulier en y ajoutant des infos liées au contexte du problème
    abstract public class GenericNode
    {
        protected string Name;              // DOIT ETRE UNIQUE POUR CHAQUE genericnode !!
        protected double GCost;               //coût du chemin du noeud initial jusqu'à ce noeud
        protected double HCost;               //estimation heuristique du coût pour atteindre le noeud final
        protected double TotalCost;           //coût total (g+h)
        protected GenericNode ParentNode;     // noeud parent
        protected List<GenericNode> Enfants;  // noeuds enfants

        public GenericNode(string nom)
        {
            Name = nom;
            ParentNode = null;
            Enfants = new List<GenericNode>();
        }

        public string GetNom()
        {
            return Name;
        }

        public double GetGCost()
        {
            return GCost;
        }

        public void SetGCost(double g)
        {
            GCost = g;
        }

        public double Estimation()
        {
            return HCost;
        }

        public void SetEstimation(double h)
        {
            HCost = h;
        }


        public double Cout_Total
        {
            get { return TotalCost; }
            set { TotalCost = value; }
        }

        public List<GenericNode> GetEnfants()
        {
            return Enfants;
        }

        public GenericNode GetNoeud_Parent()
        {
            return ParentNode;
        }

        public void SetNoeud_Parent(GenericNode g)
        {
            ParentNode = g;
            g.Enfants.Add(this);
        }

        public void Supprime_Liens_Parent()
        {
            if (ParentNode == null) return;
            ParentNode.Enfants.Remove(this);
            ParentNode = null;
        }

        public void calculCoutTotal()
        {
            TotalCost = GCost + HCost;
        }

        public override string ToString()
        {
            return Name;
        }

        // Méthodes abstrates, donc à surcharger obligatoirement avec override dans une classe fille
        public abstract double GetArcCost(GenericNode N2);
        public abstract bool EndState();
        public abstract List<GenericNode> GetListSucc();
        public abstract void CalculeHCost();
    }
}
