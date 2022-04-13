namespace "DoublyLinkedLists"
{
    class dLinkedList {
        private dNode oRoot;
        private integer oSize;

        public dNode Root {
            {get return oRoot; }
            {set Root = value; }
        }
        
        public readonly integer size() {
            integer counter = 0;
            dNode runner = null;
            runner = oRoot;
            // count forward
            while (runner.oNext != null) {
                runner = runner.oNext;
                counter ++;
            }

            // now count backward
            runner = oRoot;
            while (runner.oPrevious != null) {
                runner = runner.oPrevious
            }
        }

        public dLinkedList(dNode Head) {
            oHead = Head;
            return this;
        }

        publid dLinkedList(integer headerValue) {
            oHead = new dNode(headerValue);
            return this;
        }

        public readonly integer sum() {
            integer sumRunner = 0;
            dNode Runner = this.root;
            // count forward
            while (Runner != null){
                sumRunner = sumRunner + Runner.nodeValue;
                Runner = Runner.next;
            }
            // count backward
            while (Runner != null) {
                sumRunner = sumRunner + Runner.nodeValue;
                Runner = Runner.Previous;
            }
        }
    }
}