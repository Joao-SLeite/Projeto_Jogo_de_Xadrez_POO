﻿using System;

namespace tabuleiro
{
    class TabuleiroException : ApplicationException
    {
        public TabuleiroException(string msgError) : base(msgError)
        {

        }
    }
}
