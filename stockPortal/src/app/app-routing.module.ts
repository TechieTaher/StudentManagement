import { ClientComponent } from "./client/client.component";
import { ProductComponent } from "./product/product.component";
import { NgModule } from "@angular/core";
import { Routes, RouterModule } from "@angular/router";

const routes: Routes = [
  { path: "", component: ProductComponent },
  { path: "customer", component: ClientComponent },
  { path: "product", component: ProductComponent },
  // { path: "bill/add", component: BillAddComponent },
  // { path: "bill/edit/:id", component: BillAddComponent },
  // { path: "bill/show/:id", component: BillShowComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}
