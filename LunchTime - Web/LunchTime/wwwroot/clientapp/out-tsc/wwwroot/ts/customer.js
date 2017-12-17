"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var Customer = (function () {
    function Customer(cusName) {
        this.cusName = cusName;
        this.visits = 0;
    }
    Customer.prototype.showName = function () {
        alert(this.cusName);
    };
    Object.defineProperty(Customer.prototype, "name", {
        get: function () {
            return this.ourName;
        },
        set: function (val) {
            this.ourName = val;
        },
        enumerable: true,
        configurable: true
    });
    return Customer;
}());
exports.Customer = Customer;
//# sourceMappingURL=customer.js.map