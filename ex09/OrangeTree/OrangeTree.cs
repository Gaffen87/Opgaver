using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeTreeSim
{
    public class OrangeTree
    {

        private int _age;
            public int Alder
            {
                get { return _age; }
                set 
                { 
                    if (_age >= 0)
                    {
                        _age = value;
                    }               
                }
            }

        private int _height;
            public int Height
            {
                get { return _height; }
                set { _height = value; }
            }

        private bool _treeAlive;
            public bool TreeAlive
            {
                get { return _treeAlive; }
                set { _treeAlive = value; }
            }

        private int _numOranges;
            public int NumOranges
            {
                get { return _numOranges;}
            }

        private int _orangesEaten;
            public int OrangesEaten
            {
                get { return _orangesEaten;}
            }

        public void OneYearPasses()
        {
            _age++;
            _orangesEaten = 0;
            
            if (_age < 80)
            {
                _height += 2;
                _treeAlive = true;
                _numOranges = (_age - 1) * 5;
            }
            else
            {
                _numOranges = 0;
                _treeAlive = false;
            }
        }

        public void EatOrange(int count)
        {
            if (_treeAlive)
            {
                _orangesEaten += count;
                _numOranges -= count;
            }            
        }
    }
}
