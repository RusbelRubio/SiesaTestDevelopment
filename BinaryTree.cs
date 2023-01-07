using System;

namespace BinaryTreeSample
{
    /// <summary>
    /// Principal Class for Implementing Binary Tree
    /// </summary>
    public class BinaryTree
    {
        #region Attributes Class
        private decimal _SumValuesNodes;
        private int _NumNodes;
        #endregion

        #region Properties Class
        public Node Root { get; set; }
        #endregion

        #region  public Method Class
        public bool Add(int value)
        {
            Node BeforeNode = null, AfterNode = this.Root;

            while (AfterNode != null)
            {
                BeforeNode = AfterNode;
                //Nuevo nodo en el arbol izquierdo 
                if (value < AfterNode.Data) 
                    AfterNode = AfterNode.LeftNode;
                //Nuevo Nodo en arbol derecho
                else if (value > AfterNode.Data) 
                    AfterNode = AfterNode.RightNode;
                else
                {
                    //El valor ingresado ya existe
                    return false;
                }
            }

            Node newNode = new() { Data = value};

            //El arbol esta vacio y sin iniciar
            if (this.Root == null)
                this.Root = newNode;
            else
            {
                if (value < BeforeNode.Data)
                    BeforeNode.LeftNode = newNode;
                else
                    BeforeNode.RightNode = newNode;
            }

            return true;
        }
        public int GetTreeDepth()
        {
            return this.GetTreeDepth(this.Root);
        }
        public decimal GetTreeAverage()
        {
            _NumNodes = 0;
            _SumValuesNodes = 0;
            return this.GetTreeAverage(this.Root);
        }
        public void TraverseInOrder(Node parent)
        {
            if (parent != null)
            {
                TraverseInOrder(parent.LeftNode);
                _SumValuesNodes += parent.Data;
                _NumNodes++;
                TraverseInOrder(parent.RightNode);
            }
        }
        public decimal GetTreeWeight()
        {
            _NumNodes = 0;
            _SumValuesNodes = 0;
            return this.GetTreeWeight(this.Root);
        }
        #endregion

        #region private Methods Class
        private int GetTreeDepth(Node parent)
        {
            return parent == null ? 0 : Math.Max(GetTreeDepth(parent.LeftNode), GetTreeDepth(parent.RightNode)) + 1;
        }
        
        private decimal GetTreeAverage(Node parent)
        {
            TraverseInOrder(parent);
            return (_SumValuesNodes / _NumNodes);
        }
        private decimal GetTreeWeight(Node parent)
        {
            TraverseInOrder(parent);
            return _SumValuesNodes ;
        }
        #endregion 
    }
}
