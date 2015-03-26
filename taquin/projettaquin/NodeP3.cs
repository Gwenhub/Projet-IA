using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projettaquin
{
    //Classe fille pour le problème Numéro 1

    class NodeP3 : GenericNode
    {
        //coordonnée départ
        private int _coordXD { get; set; }
        private int _coordYD { get; set; }

        //coordonnées arrivée
        private int _coordXA { get; set; }
        private int _coordYA { get; set; }

        //niveau de batterie
        private int _batterie;

        //liste pieces
        private List<int> _toClean;
        //piece actuelle
        private int _position;

        //
        private char[,] _map { get; set; }
        private string _end;

        //Récupération des coordonnées du point de départ et du point d'arrivée 
        public NodeP3(string name, string end, char[,] map, int Bat, List<int> TC, int Pos )
            : base(name)
        {

            _end = end;

            _coordXD = 16;
            _coordYD = 16;

            _coordXA = int.Parse(end.Split(',')[0]);
            _coordYA = int.Parse(end.Split(',')[1]);

            _map = map;

            _batterie = Bat;
            _toClean = new List<int> { };
            _toClean = TC;

            _position = Pos;

        }


        public override double GetArcCost(GenericNode N2)
        {
            return (1);
        }


        //Permet de savoir si la position du noeud actuel est la position finale
        public override bool EndState()
        {
            return (_toClean.Count == 0);
        }



        //Permet de créer la liste des successeurs
        public override List<GenericNode> GetListSucc()
        {
            char[,] tab = _map;

            int posx = _coordXD;
            int posy = _coordYD;


            List<GenericNode> lsucc = new List<GenericNode>();


            //Successeur
            switch(_position)
            {
                case 1:
                    string name12 = "4,8";
                    string name13 = "11,4";
                    _toClean.Remove(1);

                    lsucc.Add(new NodeP3(name12, _end, _map, _batterie, _toClean, 2));
                    lsucc.Add(new NodeP3(name13, _end, _map, _batterie, _toClean, 4));
                    break;

                case 2:
                    string name22 = "4,2";
                    string name23 = "7,15";
                    _toClean.Remove(2);
                    lsucc.Add(new NodeP3(name22, _end, _map, _batterie, _toClean, 1));
                    lsucc.Add(new NodeP3(name23, _end, _map, _batterie, _toClean, 3));
                    break;

                case 3:
                    string name32 = "4,8";
                    string name33 = "14,9";
                    _toClean.Remove(3);
                    lsucc.Add(new NodeP3(name32, _end, _map, _batterie, _toClean, 2));
                    lsucc.Add(new NodeP3(name33, _end, _map, _batterie, _toClean, 6));
                    break;

                case 4:
                    string name42 = "4,2";
                    string name43 = "14,9";
                    _toClean.Remove(4);
                    lsucc.Add(new NodeP3(name42, _end, _map, _batterie, _toClean, 1));
                    lsucc.Add(new NodeP3(name43, _end, _map, _batterie, _toClean, 6));
                    break;

                case 5:
                    string name51 = "14,9";
                    _toClean.Remove(5);
                    lsucc.Add(new NodeP3(name51, _end, _map, _batterie, _toClean, 6));
                    break;

                case 6:
                    string name62 = "7,15";
                    string name63 = "11,4";
                    string name64 = "17,4";
                    string name65 = "16,16";
                    _toClean.Remove(6);
                    lsucc.Add(new NodeP3(name62, _end, _map, _batterie, _toClean, 3));
                    lsucc.Add(new NodeP3(name63, _end, _map, _batterie, _toClean, 4));
                    lsucc.Add(new NodeP3(name64, _end, _map, _batterie, _toClean, 5));
                    lsucc.Add(new NodeP3(name65, _end, _map, _batterie, _toClean, 7));
                    break;

                case 7:
                    string name72 = "14,9";
                    _toClean.Remove(7);
                    lsucc.Add(new NodeP3(name72, _end, _map, _batterie, _toClean, 6));
                    break;

            }

            return lsucc;
        }


        public override void CalculeHCost()
        {
            SetEstimation(0);
        }


        //Non utilisé
        /*private string GetStringFromTab ( char [,] tab )
        {
            string newname = "";
            for (int j=0;j<=2; j++)
                for (int i=0;i<=2;i++)
                    {
                       newname = newname + tab[i,j]; 
                   }  
            return newname;
        }*/
    }
}
