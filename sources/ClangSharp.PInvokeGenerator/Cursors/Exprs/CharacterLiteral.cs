﻿using System.Diagnostics;

namespace ClangSharp
{
    internal sealed class CharacterLiteral : Expr
    {
        public CharacterLiteral(CXCursor handle, Cursor parent) : base(handle, parent)
        {
            Debug.Assert(handle.Kind == CXCursorKind.CXCursor_CharacterLiteral);
        }
    }
}