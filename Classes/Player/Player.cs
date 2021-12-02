using System.Collections.Generic;
using System.Drawing;
namespace ChineseChess {
    class Player {
        private string name;
        private bool isAI;
        public Player(string name, bool isAI) {
            this.name = name;
            this.isAI = isAI;
        }
        public string Name {
            get => this.name;
            set { this.name = value; }
        }
    }
}