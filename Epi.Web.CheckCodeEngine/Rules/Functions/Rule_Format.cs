﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using com.calitha.goldparser;

namespace Epi.Core.EnterInterpreter.Rules
{
    /// <summary>
    /// Class for the Rule_Format reduction.
    /// </summary>
    public partial class Rule_Format : EnterRule
    {
        private List<EnterRule> ParameterList = new List<EnterRule>();

        public Rule_Format(Rule_Context pContext, NonterminalToken pToken)
            : base(pContext)
        {
            this.ParameterList = EnterRule.GetFunctionParameters(pContext, pToken);
        }


        /// <summary>
        /// formats a string based on the format parameter
        /// </summary>
        /// <returns>object</returns>
        public override object Execute()
        {
            object result = null;
            if (ParameterList.Count > 1)
            {
                object LHSO = ParameterList[0].Execute();
                object RHSO = ParameterList[1].Execute();

                if (LHSO != null && !Util.IsEmpty(LHSO) && RHSO != null)
                {
                    result = Microsoft.VisualBasic.Strings.Format(LHSO.ToString(), RHSO.ToString());
                }
            }
            else
            {
                result = ParameterList[0].Execute().ToString();
            }

            return result;
        }
    }


}
