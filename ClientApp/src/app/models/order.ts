export interface IOrder
{
    orderTotal:number;
    orderItems:IOrderItem[];
    orderId:number;
}
export interface IOrderItem{
    numberOfOrders:number;
    itemName:string;
    price:number;
    itemId:number;
    orderItemId:number;
}