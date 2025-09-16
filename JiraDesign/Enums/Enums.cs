using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LLD_Q.JiraDesign.Enums
{
    public enum PRIOTIY
    {
        LOW,
        MEDIUM,
        HIGH
    }
    public enum TASK_TYPE
    {
        BUG,
        ENHACEMENT,
        USER_STORY
    }

    public enum TASK_STATUS
    {
        OPEN,
        INPROGRESS,
        DONE,
        REOPEN
    }
}