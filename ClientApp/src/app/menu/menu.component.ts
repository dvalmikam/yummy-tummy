import { IOrderItem } from './../models/order';
import { IOrder } from '../models/order';
import { IMenu } from './../models/menu.interface';
import { MenuService } from './../services/menu.service';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-menu',
  templateUrl: './menu.component.html',
  styleUrls: ['./menu.component.css']
})
export class MenuComponent implements OnInit {

  public regularMenuItems:IMenu[]=[];
  public cateringMenuItems:IMenu[]=[];
  public orderList:IOrder;
  constructor(private menuService:MenuService) { }

  ngOnInit() {
    this.menuService.getMenu().subscribe(resp=>{
      
      this.regularMenuItems=resp.filter(item=>item.type=="Regular");
      //console.log(this.regularMenuItems);
      this.cateringMenuItems=resp.filter(item=>item.type=="Catering");
    });
    this.orderList={orderTotal:0, orderItems:[], orderId:0};
  }

  public addToCart(item:IMenu)
  {
    //console.log(item);
    var orderItem = this.orderList.orderItems.find(e=>e.itemId==item.itemId);
    if(!orderItem)
      this.orderList.orderItems.push({numberOfOrders:1,itemName:item.itemName, itemId:item.itemId, price:item.price, orderItemId:0});
    else
    {
      orderItem.numberOfOrders++;
      orderItem.price = orderItem.price+item.price;
    }
    this.orderList.orderTotal+=item.price;
  }

  public checkout()
  {
    this.menuService.addOrder(this.orderList).subscribe(resp=>{
      console.log(resp);
    });
  }
  public removeItem(orderItem:IOrderItem)
  {
    var indx = this.orderList.orderItems.findIndex(e=>e.itemId==orderItem.itemId);
    this.orderList.orderItems.splice(indx,1);
    this.orderList.orderTotal-=orderItem.price;
  }

}
