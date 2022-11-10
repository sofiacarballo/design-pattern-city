namespace DesignPatterns;

public class RabbitMq : IMediatorMarken
{
    private ShipmentService shipmentService { get; set; }
    
    public RabbitMq(ShipmentService shipmentService)
    {
        this.shipmentService = shipmentService;
    }
    public MarkenResponse Publish(EventPublisher eventPublisher, MarkenEvent @event)
    {
        switch (@event)
        {
            case MarkenEvent.ShipmentCollected:
                if (shipmentService.OfficeAvailable())
                {
                    return MarkenResponse.Good;
                }

                break;
            
            case MarkenEvent.ShipmentReady:
                return MarkenResponse.Good;
            
            default:
                return MarkenResponse.Bad;
        }

        return MarkenResponse.Bad;
    }
}