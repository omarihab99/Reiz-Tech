using System;
using System.Collections.Generic;
namespace branches
{
    class Branch{
        public List<Branch> branches;
        public Branch(){
            branches = new List<Branch>();
        }
    }
    class Program
    {
        static int CalculateDepth(Branch main){
            if(main.branches.Count == 0){
                return 1;
            }
            int[] depth = new[main.branches.Count];
            for(int i=0; i<depth.Length; i++){
                depth[i] = CalculateDepth(main.branches[i]);
            }
            return depth.Max()+1;
        }
        static void Main(string[] args)
        {
            Branch root = new Branch();
            Branch branch1 = new Branch();
            Branch branch2 = new Branch();
            Branch branch3 = new Branch();
            Branch branch4 = new Branch();
            Branch branch5 = new Branch();
            Branch branch6 = new Branch();
            Branch branch7 = new Branch();
            Branch branch8 = new Branch();
            Branch branch9 = new Branch();
            Branch branch10 = new Branch();
            root.branches.Add(branch1);
            root.branches.Add(branch2);  
            branch1.branches.Add(branch3); 
            branch2.branches.Add(branch4);
            branch2.branches.Add(branch5);
            branch2.branches.Add(branch6);
            branch4.branches.Add(branch7);
            branch5.branches.Add(branch8);
            branch5.branches.Add(branch9);
            branch8.branches.Add(branch10);
            Console.WriteLine(CalculateDepth(root));
        }
    }
}