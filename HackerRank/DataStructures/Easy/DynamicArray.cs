using FluentAssertions;
using HackerRank.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace HackerRank.DataStructures.Easy
{
    internal class DynamicArray
    {
        // https://www.hackerrank.com/challenges/dynamic-array

        public static List<int> dynamicArray(int n, List<List<int>> queries)
        {           
            var arrays = new List<List<int>>();
            var answers = new List<int>();
            int lastAnswer = 0;
            arrays.AddRange(Enumerable.Range(0,n).Select(i => new List<int>()));

            foreach ( var query in queries ) 
            {
                var idx = (query[1] ^ lastAnswer) % n;

                switch (query[0])
                {
                    case 1:
                        arrays[idx].Add(query[2]);
                        break;
                    case 2:
                        lastAnswer = arrays[idx][query[2] % arrays[idx].Count];
                        answers.Add(lastAnswer);
                        break;
                }
            }

            return answers;
        }
    }

    public class DynamicArrayTest
    {
        [Fact]
        public void Test()
        {
            // arrange

            var n = 2;
            var queries = new List<List<int>>()
            {
                Utils.List(1,0,5),
                Utils.List(1,1,7),
                Utils.List(1,0,3),
                Utils.List(2,1,0),
                Utils.List(2,1,1),

            };

            List<int> expectedResult = Utils.List(7,3);

            //act

            var result = DynamicArray.dynamicArray(n,queries);

            // assert

            result.Should().BeEquivalentTo(expectedResult);
        }
    }
}
