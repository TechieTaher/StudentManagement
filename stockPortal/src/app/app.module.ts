import { BrowserModule } from "@angular/platform-browser";
import { NgModule } from "@angular/core";

import { AppRoutingModule } from "./app-routing.module";
import { AppComponent } from "./app.component";

import { ClientComponent } from "./client/client.component";
import { ProductComponent } from "./product/product.component";
import { ClientAddComponent } from "./client/client-add/client-add.component";
import { ProductAddComponent } from "./product/product-add/product-add.component";
import { FormsModule, ReactiveFormsModule } from "@angular/forms";
import { clients } from "./client";
import { products } from "./product";

@NgModule({
  declarations: [
    AppComponent,
    ClientComponent,
    ProductComponent,
    ClientAddComponent,
    ProductAddComponent,
  ],
  imports: [FormsModule, ReactiveFormsModule, BrowserModule, AppRoutingModule],

  providers: [
    { provide: "clients", useValue: clients },
    { provide: "products", useValue: products },
  ],
  bootstrap: [AppComponent],
})
export class AppModule {}
