import { Component, OnInit, Input } from '@angular/core';
import { Observable } from 'rxjs';
import { IBasket } from 'src/app/shared/models/basket';
import { BasketService } from 'src/app/basket/basket.service';
import { ToastrService } from 'ngx-toastr';
import { CdkStepper } from '@angular/cdk/stepper';

@Component({
  selector: 'app-checkout-review',
  templateUrl: './checkout-review.component.html',
  styleUrls: ['./checkout-review.component.scss']
})
export class CheckoutReviewComponent implements OnInit {
  // @Input() appStepper: CdkStepper;
  // basket$: Observable<IBasket>;

  // constructor(private basketService: BasketService, private toastr: ToastrService) { }
  constructor() {}
  // tslint:disable-next-line: typedef
  ngOnInit() {
    // this.basket$ = this.basketService.basket$;
  }

  // createPaymentIntent() {
  //   return this.basketService.createPaymentIntent().subscribe((response: any) => {
  //     this.appStepper.next();
  //   }, error => {
  //     console.log(error);
  //   });
  // }

}
