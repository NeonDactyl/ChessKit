using NeonDactyl.ChessLogic.Primitives;
using System;
using System.Collections.Generic;
using System.Text;

namespace NeonDactyl.ChessLogic.Algorithms
{
    public static partial class Attacks
    {
        public static bool IsSquareAttackedBySide(this PositionCore core, Color side, int square)
        {
            return side == Color.White
                ? IsSquareAttackedByWhite(core.Cells, square)
                : IsSquareAttackedByBlack(core.Cells, square);
        }

        public static bool IsInCheck(this PositionCore core, Color side)
        {
            return side == Color.White
                ? IsSquareAttackedByBlack(core.Cells, core.WhiteKing)
                : IsSquareAttackedByWhite(core.Cells, core.BlackKing);
        }
    }
}
