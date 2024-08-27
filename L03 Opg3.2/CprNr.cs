namespace L03_APp.Opg3._1;

public class CprNr
{
    private String birthDate;
    
    private String sequenceNumber;

    public CprNr(string bDate, string sNumber)
    {
        BirthDate = bDate;
        SequenceNumber = sNumber;
    }

    public string BirthDate
    {
        get => birthDate;
        set => birthDate = value;
    }

    public string SequenceNumber
    {
        get => sequenceNumber;
        set => sequenceNumber = value;
    }

    public override string ToString()
    {
        return BirthDate + SequenceNumber;
    }
}