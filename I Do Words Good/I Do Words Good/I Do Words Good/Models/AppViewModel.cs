using System;
using System.Collections.Generic;
using System.Text;

namespace I_Do_Words_Good.Models
{
    public class AppViewModel
    {
        public Game GameOfTheDay { get; set;}
        public Game ContinueGame { get; set; }
    }
}




/*
        --color-present: var(--darkendYellow);
        --color-correct: var(--darkendGreen);
        --color-absent: var(--color-tone-4);
        --tile-text-color: var(--color-tone-1);
        --key-text-color: var(--color-tone-1);
        --key-evaluated-text-color: var(--color-tone-1);
        --key-bg: var(--color-tone-2);
        --key-bg-present: var(--color-present);
        --key-bg-correct: var(--color-correct);
        --key-bg-absent: var(--color-absent);
        --modal-content-bg: var(--color-tone-7);
*/