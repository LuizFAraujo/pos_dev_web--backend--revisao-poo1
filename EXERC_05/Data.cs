namespace DataUtil;

public class DataObj
{
    private DateTime data1;
    private DateTime data2;
    private long diferencaDias;

    public DateTime Data1 { get { return data1; } set { data1 = value; } }
    public DateTime Data2 { get { return data2; } set { data2 = value; } }
    public long DiferencaDias { get { return diferencaDias; } set { diferencaDias = value; } }

    public long CalcDiasDif_DuasDatas(DateTime data1, DateTime data2)
    {
        TimeSpan dif = data2 - data1;
        return Math.Abs(dif.Days);
    }

    public override string ToString()
    {
        return $" A diferença entre {data1.ToString("dd/MM/yyyy")} e {data2.ToString("dd/MM/yyyy")}, é de {diferencaDias} dias.";
    }


}
