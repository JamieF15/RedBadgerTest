using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace RedBadgerForms
{
    internal class GridElement : PictureBox
    {
        private bool hasScent = false;
        private Point coodinates;

        public GridElement(Point coodinates)
        {
            this.coodinates = coodinates;
        }
        
        public void SetHasScent(bool hasScent)
        {
            this.hasScent = hasScent;
        }
        public bool GetHasScent()
        {
            return hasScent;
        }

        public void SetRobotInElement()
        {

        }

        public Point GetCoordinates()
        {
            return coodinates;
        }

        public void SetCoordinates(Point coodinates)
        {
            this.coodinates = coodinates;
        }
    }
}
