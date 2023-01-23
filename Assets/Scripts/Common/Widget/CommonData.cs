using System;
using System.Collections.Generic;

public struct CommonButtonData
{
    public string tips;
    public Action func;
}

public struct CommonDialogData
{
    public string title;
    public string tips;
    public List<CommonButtonData> data;
}