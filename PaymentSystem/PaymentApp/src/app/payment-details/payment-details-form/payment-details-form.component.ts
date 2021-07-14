import { Component, OnInit } from '@angular/core';
import { PaymentDetailService } from './../../shared/payment-detail.service';
import { PaymentDetail } from 'src/app/shared/payment-detail.model';
import { NgForm } from '@angular/forms';
import {ToastrService} from 'ngx-toastr'
@Component({
  selector: 'app-payment-details-form',
  templateUrl: './payment-details-form.component.html',
  styles: [
  ]
})
export class PaymentDetailsFormComponent implements OnInit {

  constructor(public service:PaymentDetailService , 
  private toastr:ToastrService) { }

  ngOnInit(): void {
  }
    resetForm(form: NgForm) {
    form.form.reset();
    this.service.formData = new PaymentDetail();
  }
  onSubmit(form: NgForm) {
  this.insertRecord(form);
}

insertRecord(form: NgForm) {
  this.service.postPaymentDetail().subscribe(
    res => {
      this.resetForm(form);
      this.toastr.success("Submit Successful","Payment Submit")
      this.service.refreshList();
    },
    err => { console.log(err); }
  )
}

}
