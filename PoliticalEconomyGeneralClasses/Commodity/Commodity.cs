public class Commodity
{
    UseValue _useValue;
    ExchangeValue _exchangeValue;
    SociallyNecessary _value;

    Commodity(UseValue useValue, ExchangeValue exchangeValue, Value value)
    {
        _useValue = useValue;
        _exchangeValue = exchangeValue;
        _value = new SociallyNecessary(value);
    }
}