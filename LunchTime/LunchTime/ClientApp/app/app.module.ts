import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
//import { HttpClientModule } from "@angular/common/http";
import { HttpModule } from '@angular/http';

import { AppComponent } from './app.component';
import { ProductList } from "./shop/productList.component";
import { Cart } from "./shop/cart.component";
import { DataService } from "./shared/dataService";

@NgModule({
  declarations: [
      AppComponent,
      ProductList,
      Cart
  ],
  imports: [
      BrowserModule,
      //HttpClientModule
      HttpModule
  ],
  providers: [
      DataService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
