import * as _ from "lodash";

export class Order {
    orderId: number;
    orderDate: Date = new Date();
    orderNumber: string;
    items: Array<OrderItem> = new Array<OrderItem>();

    get total(): number {
        return _.sum(_.map(this.items, i => i.productPrice * i.quantity));
    };
}

export class OrderItem {
    id: number;
    quantity: number;
    productId: number;
    productName: string;
    productPrice: number;
    productDescription: string;
}