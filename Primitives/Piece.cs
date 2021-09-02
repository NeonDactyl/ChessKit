using System;
using static NeonDactyl.ChessLogic.Primitives.Color;
using static NeonDactyl.ChessLogic.Primitives.PieceType;

namespace NeonDactyl.ChessLogic.Primitives
{
    /// <summary>Represents pieces on the board (color + type) </summary>
    [Flags]
    public enum Piece : byte
    {
        EmptyCell,
        
        WhitePawn   = White | Pawn,
        WhiteBishop = White | Bishop,
        WhiteKnight = White | Knight,
        WhiteRook   = White | Rook,
        WhiteQueen  = White | Queen,
        WhiteKing   = White | King,
        
        BlackPawn   = Black | Pawn,
        BlackBishop = Black | Bishop,
        BlackKnight = Black | Knight,
        BlackRook   = Black | Rook,
        BlackQueen  = Black | Queen,
        BlackKing   = Black | King
    }
}                                                    