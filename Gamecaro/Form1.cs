﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gamecaro
{
    public partial class Form1 : Form
    {
        #region poperties
        chessboardmanager ChessBoard;
        #endregion
        public Form1()
        {
            InitializeComponent();

            ChessBoard = new chessboardmanager(pnlchessboard);

            ChessBoard.Drawchessboard();
        }
        
    }
}
