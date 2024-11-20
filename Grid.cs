using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace RedBadgerForms
{
    internal class Grid
    {
        public static void Initiate(int x, int y, Form form)
        {
            int gridElementSize = 50;
            int startingXLocation = 0;
            int startingYLocation = 500;
            int currentXLocaiton = startingXLocation;
            int currentYLocaiton = startingYLocation;
       
            int elementCount = 0;
            
            for (int i = 0; i < x; i++) // x = 5
            {
        
                currentYLocaiton -= gridElementSize;
                currentXLocaiton = startingXLocation;
                
                for (int j = 0; j < y; j++) // x = 3
                {
                    GridElement gridElement = new GridElement(new Point(i, j));
                    gridElement.Size = new Size(gridElementSize, gridElementSize);
                    
                    gridElement.BackColor = Color.Black;
                    gridElement.Location = new Point(currentXLocaiton, currentYLocaiton);
                    form.Controls.Add(gridElement);
                    currentXLocaiton += gridElementSize;
                    elementCount += 1;
                }
            }
        }
    }
}
