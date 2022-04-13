namespace DoublyLinkedLists
{
    class dNode
    {
        private integer oNodeValue;
        private dNode oPrevious;
        private dNode oNext;

        public integer nodeValue{
            {get return nodeValue; }
            {set nodeValue = value; }
        }

        public dNode Previous {
            {get return oPrevious; }
            {set oPrevious = value; }
        }

        public dNode Next {
            {get return oNext; }
            {set oNext = value; }
        }
        public dNode(integer nodeValue){
            onodeValue = nodeValue;
        }
        
        public dNode(integer nodeValue, dNode Previous) {
            onodeValue = nodeValue;
            oPreviousNode = Previous;
        }

        public dNode(string nodeValue, dNode Previous, dNode Next) {
            oNodeValue = nodeValue;
            oPreviousNode = Previous;
            oNextNode = Next;
        }
    }
}
