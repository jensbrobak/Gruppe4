import { Injectable } from "@angular/core";
//import { HttpClient } from "@angular/common/http";
import { Http, Response } from "@angular/http";
import { Observable } from "rxjs";
import { Product } from "./product";

import 'rxjs/add/operator/map';
import { Order, OrderItem} from "./order";

@Injectable()
export class DataService {

    //constructor(private http: HttpClient) {

    //}

    //public products = [];

    //public loadProducts() {
    //    return this.http.get("/api/products")
    //        .map((data: any[]) => {
    //            this.products = data;
    //            return true;
    //        });
    //}


    constructor(private http: Http) {

    }

    public order: Order = new Order();

    public products: Product[] = [];

    public loadProducts(): Observable<Product[]> {
        return this.http.get("/api/products")
            .map((result: Response) => this.products = result.json());
    }

    public AddToOrder(product: Product) {

        let item: OrderItem = this.order.items.find(i => i.productId == product.id);

        if (item) {
            item.quantity++;
        }
        else {

            item = new OrderItem();
            item.productId = product.id;
            item.productName = product.name;
            item.productDescription = product.description;
            item.productPrice = product.price;
            item.quantity = 1;

            this.order.items.push(item);
        }
    }
}