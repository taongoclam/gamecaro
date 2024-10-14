using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gamecaro
{
    public  class chessboardmanager
    {
        #region properties
        private Panel chessBoard;

        public Panel ChessBoard
        {
            get { return chessBoard; }
            set { chessBoard = value; }
        }

        #endregion
        #region Initialize
        public chessboardmanager(Panel chessBoard)
        {
            this.chessBoard = chessBoard;
        }
        #endregion

        #region Methods
        public void Drawchessboard()
        {
            Button oldbutton = new Button()
            {
                Width = 0,
                Location = new Point(0, 0)
            };

            for (int i = 0; i < cons.CHESS_BOARD_HEIGHT; i++)
            {
                for (int j = 0; j < cons.CHESS_BOARD_WIDTH; j++)
                {

                    Button btn = new Button()
                    {
                        Width = cons.CHESS_WIDTH,
                        Height = cons.CHESS_HEIGHT,
                        Location = new Point(oldbutton.Location.X + cons.CHESS_WIDTH, oldbutton.Location.Y)
                    };

                    chessBoard.Controls.Add(btn);
                    oldbutton = btn;
                }

                oldbutton.Location = new Point(0, oldbutton.Location.Y + cons.CHESS_HEIGHT);

                oldbutton.Width = 0;
                oldbutton.Height = 0;
            }
        }
        #endregion


    }
}
