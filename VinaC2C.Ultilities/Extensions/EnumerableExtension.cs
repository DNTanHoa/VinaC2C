using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VinaC2C.Ultilities.TemplateModel;

namespace VinaC2C.Ultilities.Extensions
{
    public static class CollectionExtension
    {
        public static IEnumerable<TreeItem<T>> GenerateTree<T,K>(this IEnumerable<T> collection, Func<T,K> id, Func<T,K> parent, K root = default(K))
        {
            foreach (var item in collection.Where(c => parent(c).Equals(root)))
            {
                yield return new TreeItem<T>
                {
                    Item = item,
                    Childrens = collection.GenerateTree(id, parent, id(item))
                };
            }
        }
    }
}
