/** \file assignment-3-BlackJack
* \brief This file contains a game called Balckjack which is a card and betting game.
* \author Tamanda Mdyanyama
* \date 5/05/2024
* \copyright University of Nicosia
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;


namespace Assignment_3_BlackJack
{
    internal class Card
    {
       public int rank=0, suit=0; //rank (0-12) suit (0-3)

        // Return the generic score value of a card (10 for a face) (11 for an ace)
        public int cardValue()
        {
            if (rank == 0)  //Ace card
            {
                return 11;
            }
            else if (rank <= 8) //Since its from 0, we just add 1
            {
                return rank + 1;
            }
            else return 10; //if rank is 9
        }

        // Assigns a case to the appropriate card image
        public Image CardImage()
        {
            switch ((13 * suit) + rank)
            {
                //Pikes
                case 0:
                    return Properties.Resources.Pikes_A_white;
                case 1:
                    return Properties.Resources.Pikes_2_white;
                case 2:
                    return Properties.Resources.Pikes_3_white;
                case 3:
                    return Properties.Resources.Pikes_4_white;
                case 4:
                    return Properties.Resources.Pikes_5_white;
                case 5:
                    return Properties.Resources.Pikes_6_white;
                case 6:
                    return Properties.Resources.Pikes_7_white;
                case 7:
                    return Properties.Resources.Pikes_8_white;
                case 8:
                    return Properties.Resources.Pikes_9_white;
                case 9:
                    return Properties.Resources.Pikes_10_white;
                case 10:
                    return Properties.Resources.Pikes_Jack_white;
                case 11:
                    return Properties.Resources.Pikes_Queen_white;
                case 12:
                    return Properties.Resources.Pikes_King_white;

                    //Hearts
                case 13:
                    return Properties.Resources.Hearts_A_white;
                case 14:
                    return Properties.Resources.Hearts_2_white;
                case 15:
                    return Properties.Resources.Hearts_3_white;
                case 16:
                    return Properties.Resources.Hearts_4_white;
                case 17:
                    return Properties.Resources.Hearts_5_white;
                case 18:
                    return Properties.Resources.Hearts_6_black; //add hearts black
                case 19:
                    return Properties.Resources.Hearts_7_white;
                case 20:
                    return Properties.Resources.Hearts_8_white;
                case 21:
                    return Properties.Resources.Hearts_9_white;
                case 22:
                    return Properties.Resources.Hearts_10_white;
                case 23:
                    return Properties.Resources.Hearts_Jack_white;
                case 24:
                    return Properties.Resources.Hearts_Queen_white;
                case 25:
                    return Properties.Resources.Hearts_King_white;

                    //Clovers
                case 26:
                    return Properties.Resources.Clovers_A_white;
                case 27:
                    return Properties.Resources.Clovers_2_white;
                case 28:
                    return Properties.Resources.Clovers_3_white;
                case 29:
                    return Properties.Resources.Clovers_4_white;
                case 30:
                    return Properties.Resources.Clovers_5_white;
                case 31:
                    return Properties.Resources.Clovers_6_white; 
                case 32:
                    return Properties.Resources.Clovers_7_white;
                case 33:
                    return Properties.Resources.Clovers_8_white;
                case 34:
                    return Properties.Resources.Clovers_9_white;
                case 35:
                    return Properties.Resources.Clovers_10_white;
                case 36:
                    return Properties.Resources.Clovers_Jack_white;
                case 37:
                    return Properties.Resources.Clovers_Queen_white;
                case 38:
                    return Properties.Resources.Clovers_King_white;

                //Tiles
                case 39:
                    return Properties.Resources.Tiles_A_white;
                case 40:
                    return Properties.Resources.Tiles_2_white;
                case 41:
                    return Properties.Resources.Tiles_3_white;
                case 42:
                    return Properties.Resources.Tiles_4_white;
                case 43:
                    return Properties.Resources.Tiles_5_white;
                case 44:
                    return Properties.Resources.Tiles_6_white; 
                case 45:
                    return Properties.Resources.Tiles_7_white;
                case 46:
                    return Properties.Resources.Tiles_8_white;
                case 47:
                    return Properties.Resources.Tiles_9_white;
                case 48:
                    return Properties.Resources.Tiles_10_white;
                case 49:
                    return Properties.Resources.Tiles_Jack_white;
                case 50:
                    return Properties.Resources.Tiles_Queen_white;
                case 51:
                    return Properties.Resources.Tiles_King_white;
                default:
                    return null;
                
            }

        }
    }
}
