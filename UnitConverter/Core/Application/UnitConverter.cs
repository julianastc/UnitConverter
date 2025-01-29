
using UnitConverter.Domain;

namespace UnitConverter.Core.Application;

public class UnitConverter
{
    public double Converter(UnitConverterEntities unitConverterEntity)
    {
        double result = 0;
        switch (unitConverterEntity.InitialUnitType)
        {
            case MeasurementsUnits.Meter:
                switch (unitConverterEntity.FinalConvertedUnitType)
                {
                    case MeasurementsUnits.Kilometer:
                        result = unitConverterEntity.UnitValue / 1000;
                        break;
                    case MeasurementsUnits.Centimeter:
                        result = unitConverterEntity.UnitValue * 100;
                        break;
                    case MeasurementsUnits.Millimeter:
                        result = unitConverterEntity.UnitValue * 1000;
                        break;
                    case MeasurementsUnits.Decimeter:
                        result = unitConverterEntity.UnitValue * 10;
                        break;
                    case MeasurementsUnits.Decameter:
                        result = unitConverterEntity.UnitValue / 10;
                        break;
                    default:
                        throw new BadHttpRequestException("Valor inválido. ");
                }
                break;
            case MeasurementsUnits.Kilometer:
                switch (unitConverterEntity.FinalConvertedUnitType)
                {
                    case MeasurementsUnits.Meter:
                        result = unitConverterEntity.UnitValue * 1000;
                        break;
                    case MeasurementsUnits.Centimeter:
                        result = unitConverterEntity.UnitValue * 100000;
                        break;
                    case MeasurementsUnits.Millimeter:
                        result = unitConverterEntity.UnitValue * 1000000;
                        break;
                    case MeasurementsUnits.Decimeter:
                        result = unitConverterEntity.UnitValue * 10000;
                        break;
                    case MeasurementsUnits.Decameter:
                        result = unitConverterEntity.UnitValue * 100;
                        break;
                    default:                         
                        throw new BadHttpRequestException("Valor inválido. ");
                }
                break;
            case MeasurementsUnits.Centimeter:
                switch (unitConverterEntity.FinalConvertedUnitType)
                {
                    case MeasurementsUnits.Meter:
                        result = unitConverterEntity.UnitValue / 100;
                        break;
                    case MeasurementsUnits.Kilometer:
                        result = unitConverterEntity.UnitValue / 100000;
                        break;
                    case MeasurementsUnits.Millimeter:
                        result = unitConverterEntity.UnitValue * 10;
                        break;
                    case MeasurementsUnits.Decimeter:
                        result = unitConverterEntity.UnitValue / 10;
                        break;  
                    case MeasurementsUnits.Decameter:
                        result = unitConverterEntity.UnitValue / 10000;
                        break;
                    default:                         
                        throw new BadHttpRequestException("Valor inválido. ");
                }
                break;
            case MeasurementsUnits.Millimeter:
                switch (unitConverterEntity.FinalConvertedUnitType)
                {
                    case MeasurementsUnits.Meter:
                        result = unitConverterEntity.UnitValue / 1000;
                        break;
                    case MeasurementsUnits.Centimeter:
                        result = unitConverterEntity.UnitValue / 10;
                        break;
                    case MeasurementsUnits.Kilometer:
                        result = unitConverterEntity.UnitValue / 1000000;
                        break;
                    case MeasurementsUnits.Decimeter:
                        result = unitConverterEntity.UnitValue / 100;
                        break; 
                    case MeasurementsUnits.Decameter:
                        result = unitConverterEntity.UnitValue / 10000;
                        break;
                    default:                         
                        throw new BadHttpRequestException("Valor inválido. ");
                }
                break;
            case MeasurementsUnits.Decimeter:
                switch (unitConverterEntity.FinalConvertedUnitType)
                {
                    case MeasurementsUnits.Meter:
                        result = unitConverterEntity.UnitValue / 10;
                        break;
                    case MeasurementsUnits.Centimeter:
                        result = unitConverterEntity.UnitValue * 10;
                        break;
                    case MeasurementsUnits.Kilometer:
                        result = unitConverterEntity.UnitValue / 10000;
                        break;
                    case MeasurementsUnits.Millimeter:
                        result = unitConverterEntity.UnitValue * 100;
                        break;   
                    case MeasurementsUnits.Decameter:
                        result = unitConverterEntity.UnitValue / 100;
                        break;
                    default:                         
                        throw new BadHttpRequestException("Valor inválido. ");
                }
                break;
            case MeasurementsUnits.Decameter:
                switch (unitConverterEntity.FinalConvertedUnitType)
                {
                    case MeasurementsUnits.Meter:
                        result = unitConverterEntity.UnitValue * 10;
                        break;
                    case MeasurementsUnits.Centimeter:
                        result = unitConverterEntity.UnitValue * 1000;
                        break;
                    case MeasurementsUnits.Kilometer:
                        result = unitConverterEntity.UnitValue / 100;
                        break;
                    case MeasurementsUnits.Decimeter:
                        result = unitConverterEntity.UnitValue * 100;
                        break;  
                    case MeasurementsUnits.Millimeter:
                        result = unitConverterEntity.UnitValue * 10000;
                        break;
                    default:                         
                        throw new BadHttpRequestException("Valor inválido. ");
                }
                break;
        }
        return result;
    }
}