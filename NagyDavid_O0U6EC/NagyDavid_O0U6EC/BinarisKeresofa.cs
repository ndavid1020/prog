using System;
using System.Collections.Generic;
namespace NagyDavid_O0U6EC
{
    enum walk_style
    {
        preorder, inorder, postorder
    }
    class BinarisKeresofa<LancoltLista>
    {
        class Node
        {
            public LancoltLista<Termek> value;
            public Node right;
            public Node left;
        }
        Node root;

        public bool Remove(LancoltLista<Termek> val)
        {
            return PrivateRemove(ref root, val);
        }

        private bool PrivateRemove(ref Node p, LancoltLista<Termek> val)
        {
            if (p == null)
            {
                return false;
            }

            int elem = p.value.meret;
            int ki = val.meret;
            if (ki > elem)
            {
                return PrivateRemove(ref p.right, val);
            }
            else if (ki < elem)
            {
                return PrivateRemove(ref p.left, val);
            }
            else
            {
                if (p.left == null)
                {
                    p = p.right;
                }
                else if (p.right == null)
                {
                    p = p.left;
                }
                else
                {
                    RemoveCaseC(p, ref p.left);
                }
                return true;
            }
        }

        private void RemoveCaseC(Node p, ref Node left)
        {
            if (left.right != null)
            {
                RemoveCaseC(p, ref left.right);
            }
            else
            {
                p.value = left.value;
                left = left.left;
            }
        }

        public void Add(LancoltLista<Termek> val)
        {
            PrivateAdd(ref root, val);
        }

        private void PrivateAdd(ref Node p, LancoltLista<Termek> val)
        {
            if (p == null)
            {
                p = new Node();
                p.value = val;
            }
            else
            {
                int elem = p.value.meret;
                int be = val.meret;
                if (be > elem)
                {
                    PrivateAdd(ref p.right, val);
                }
                else if (be <= elem)
                {
                    PrivateAdd(ref p.left, val);
                }
            }
        }

        public IEnumerable<LancoltLista<Termek>> WidthWalk()
        {
            List<LancoltLista<Termek>> list = new List<LancoltLista<Termek>>();
            Queue<Node> Q = new Queue<Node>();
            Q.Enqueue(root);

            while (Q.Count > 0)
            {
                Node p = Q.Dequeue();
                list.Add(p.value);
                if (p.left != null)
                {
                    Q.Enqueue(p.left);
                }
                if (p.right != null)
                {
                    Q.Enqueue(p.right);
                }
            }
            return list;
        }

        public IEnumerable<LancoltLista<Termek>> DeptWalk()
        {
            Stack<Node> S = new Stack<Node>();
            S.Push(root);
            while (S.Count > 0)
            {
                Node p = S.Pop();
                yield return p.value;
                if (p.left != null)
                {
                    S.Push(p.left);
                }
                if (p.right != null)
                {
                    S.Push(p.right);
                }
            }
        }

        public IEnumerable<LancoltLista<Termek>> CustomOrder(walk_style walk)
        {
            List<LancoltLista<Termek>> list = new List<LancoltLista<Termek>>();
            PrivateCustomOrder(root, walk, list);
            return list;
        }

        private void PrivateCustomOrder(Node p, walk_style walk, List<LancoltLista<Termek>> list)
        {
            if (p != null)
            {

                if (walk == walk_style.preorder)
                {
                    list.Add(p.value);
                }

                PrivateCustomOrder(p.left, walk, list);

                if (walk == walk_style.inorder)
                {
                    list.Add(p.value);
                }

                PrivateCustomOrder(p.right, walk, list);

                if (walk == walk_style.postorder)
                {
                    list.Add(p.value);
                }
            }
        }
    }
}
