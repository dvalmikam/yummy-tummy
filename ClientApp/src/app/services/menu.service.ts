import { Injectable, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { IMenu } from '../models/menu.interface';
import { IOrderItem, IOrder } from '../models/order';

@Injectable({
  providedIn: 'root'
})
export class MenuService {
  public apiUrl:string;

  constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this.apiUrl=baseUrl;
  }

  getMenu():Observable<IMenu[]>
  {
    console.log(this.apiUrl);
    return this.http.get<IMenu[]>(this.apiUrl + 'api/menuItems');
  }

  addOrder(order:IOrder):Observable<IOrder>
  {
    return this.http.post<IOrder>(this.apiUrl + 'api/addOrder', order);
  }
}
