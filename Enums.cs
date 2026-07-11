using System;
using System.Collections.Generic;
using System.Text;

namespace STUDY.MathGame
{
    internal class Enums
    {
        internal enum Menu
        {
            StartGame,
            ViewHistory,
            CleanHistory
        }
        internal enum Operation
        {
            Addition ='+',
            Substraction='-',
            Multiplication='*',
            Division='/'
        }
        internal enum Difficulty
        {
            Easy=10,
            Medium=100,
            Hard=1000
        }
    }
}
