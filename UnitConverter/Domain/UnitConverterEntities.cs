namespace UnitConverter.Domain;

public class UnitConverterEntities
{
    public double UnitValue { get; set; }
    
    public MeasurementsUnits InitialUnitType { get; set; }
    
    public MeasurementsUnits FinalConvertedUnitType { get; set; }
}