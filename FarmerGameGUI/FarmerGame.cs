using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace FarmerGameGUI
{
    class FarmerGame
    {
        private Direction farmer;
        private ArrayList northBank = new ArrayList();
        private ArrayList southBank = new ArrayList();

        internal Direction Farmer { get => farmer; set => farmer = value; }

        public string AnimalAteFood()
        {
            string eaten = "NOTHING";
            if (NorthBank.Contains("FOX") && NorthBank.Contains("CHICKEN") && Farmer == Direction.South ||
                 SouthBank.Contains("FOX") && SouthBank.Contains("CHICKEN") && Farmer == Direction.North)
            {
                return eaten = "FoxAteChicken";
            }
            else if (NorthBank.Contains("CHICKEN") && NorthBank.Contains("GRAIN") && Farmer == Direction.South ||
                 SouthBank.Contains("CHICKEN") && SouthBank.Contains("GRAIN") && Farmer == Direction.North)
            {
                return eaten = "ChickenAteGrain";
            }
            else
            {
                return eaten;
            }
        }
        public bool DetermineWin()
        {
            if (SouthBank.Contains("FOX") &&
                SouthBank.Contains("CHICKEN") &&
                SouthBank.Contains("GRAIN") &&
                Farmer == Direction.South)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public FarmerGame()
        {
            NorthBank.Add("FOX");
            NorthBank.Add("CHICKEN");
            NorthBank.Add("GRAIN");
            Farmer = Direction.North;
        }
        public void Move(string moving)
        {
            string itemToMove = moving;
            if (itemToMove != "NOTHING")
            {
                if (Farmer == Direction.North)
                {
                    if (NorthBank.Contains(itemToMove))
                    {
                        NorthBank.Remove(itemToMove);
                        SouthBank.Add(itemToMove);
                    }
                    Farmer = Direction.South;
                }
                else
                {
                    if (SouthBank.Contains(itemToMove))
                    {
                        SouthBank.Remove(itemToMove);
                        NorthBank.Add(itemToMove);
                    }
                    Farmer = Direction.North;
                }
            }
            else
            {
                if (Farmer == Direction.North)
                {
                    Farmer = Direction.South;
                }
                else
                {
                    Farmer = Direction.North;
                }
            }
        }
        public enum Direction
        {
            North,
            South
        }
        public ArrayList NorthBank
        {
            get { return northBank; }
        }
        public ArrayList SouthBank
        {
            get { return southBank; }
        }
    }
}