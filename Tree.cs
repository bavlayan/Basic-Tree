public class Tree
    {
        public Node Head { get; set; }

        public int Score { get; set; }

        public bool Insert(Node currentHead, Node toInsertedNode, Node parent)
        {
            if (Head == null)
            {
                Head = toInsertedNode;
                return true;
            }
            if (currentHead == parent)
            {
                currentHead.Childs.Add(toInsertedNode);
                return true;
            }

            for (int index = 0; index < currentHead.Childs.Count; index++)
            {
                if (currentHead.Childs[index] != null && Insert(currentHead.Childs[index], toInsertedNode, parent))
                {
                    return true;
                }

            }
            return false;

        }

        public bool Delete(Node currentHead, Node toDeletedNode)
        {
            if (Head == null)
                return false;

            if (currentHead.Childs != null && currentHead.Childs.Contains(toDeletedNode))
            {
                currentHead.Childs.Remove(toDeletedNode);
                return true;
            }
            for (int index = 0; index < currentHead.Childs.Count; index++)
            {
                if (currentHead.Childs[index] != null && Delete(currentHead.Childs[index], toDeletedNode))
                {
                    return true;
                }
            }
            return false;
        }

        public bool Update(Node currentHead, Node toUpdatedNode)
        {
            if (currentHead != null && currentHead.Id == toUpdatedNode.Id)
            {
                currentHead.Name = toUpdatedNode.Name;
                return true;
            }
            for (int index = 0; index < currentHead.Childs.Count; index++)
            {
                if (currentHead.Childs[index] != null && Update(currentHead.Childs[index], toUpdatedNode))
                {
                    return true;
                }
            }

            return false;
        }

        public int GetTreeScore(Node currentHead)
        {
            Score = 0;
            return GetScore(currentHead);
        }

        private int GetScore(Node currentHead)
        {
            if (currentHead != null && currentHead.Childs != null && currentHead.Childs.Count == 0)
            {
                return Score++;
            }
            for (int index = 0; index < currentHead.Childs.Count; index++)
            {
                GetScore(currentHead.Childs[index]);
            }
            return Score;
        }
    }
