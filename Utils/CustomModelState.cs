using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TPModule5_2_BO;

namespace TPModule5_2.Utils
{
    public class CustomModelState
    {
        public bool CheckListLength(IList LstToCheck )
        {
            if(LstToCheck.Count<5)
            {
                return false;
            }
            return true;
        }

        public bool CheckIdPate(int id)
        {
            if(id == 0)
            {
                return false;
            }
            return true;
        }

        public bool CheckIngredient(List<Ingredient> LstToCheck1, List<Ingredient> LstToCheck2)
        {
            if(LstToCheck1.All(LstToCheck2.Contains)&& LstToCheck1.Count == LstToCheck2.Count)
            {
                return false;
            }
            return true;
        }
    }
}