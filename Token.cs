using System;

namespace Stone{


    public abstract class Token {
        public static readonly Token EOF = new Token(-1){};
        public static const string EOL = "\\n";
        public int lineNumber{ get; }

        protected Token(int line){
            lineNumber = line;
        }

        public bool isIdentifier(){
            return false;
        }

        public bool isNumber() {
            return false;
        }

        public bool isString() {
            return false;
        }

        public int getNumber() {
            throw new StoneException("not number token");
        }

        public string getText() {
            return "";
        }
    }


}
