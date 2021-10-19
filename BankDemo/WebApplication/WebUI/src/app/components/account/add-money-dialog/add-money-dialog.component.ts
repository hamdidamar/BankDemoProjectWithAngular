import { Component, Input, OnInit } from '@angular/core'
import { NgbModal, ModalDismissReasons } from '@ng-bootstrap/ng-bootstrap'

import { ActivatedRoute, Params, Router } from '@angular/router'
import { AccountService } from 'src/app/services/account/account.service'

@Component({
  selector: 'app-add-money-dialog',
  templateUrl: './add-money-dialog.component.html',
  styleUrls: ['./add-money-dialog.component.scss'],
})
export class AddMoneyDialogComponent implements OnInit {
  @Input() moneyAmount: any = 0
  item: any
  constructor(private modalService: NgbModal, private route: ActivatedRoute,private accountService: AccountService,private router:Router) {}

  ngOnInit() {
    this.route.params.subscribe(
      (params: Params) => (this.item = params['item']),
    )
    this.item = JSON.parse(this.item)
  }
  onAddMoneyClick() {
    if (this.moneyAmount > 0) {
    this.accountService.addMoney(this.item.accountId,this.moneyAmount).subscribe((data) => {
      alert(data)
      this.router.navigate(['account'])
    })}
    else{
      alert("Amount must be integer and bigger than 0");
    }
  }
}
