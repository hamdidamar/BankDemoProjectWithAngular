import { Component, Input, OnInit } from '@angular/core'
import { ActivatedRoute, Params, Router } from '@angular/router'
import { AccountService } from 'src/app/services/account/account.service'

@Component({
  selector: 'app-take-money-dialog',
  templateUrl: './take-money-dialog.component.html',
  styleUrls: ['./take-money-dialog.component.scss'],
})
export class TakeMoneyDialogComponent implements OnInit {
  @Input() moneyAmount: any = 0
  item: any
  constructor(
    private route: ActivatedRoute,
    private accountService: AccountService,
    private router: Router,
  ) {}

  ngOnInit() {
    this.route.params.subscribe(
      (params: Params) => (this.item = params['item']),
    )
    this.item = JSON.parse(this.item)
  }
  onTakeMoneyClick() {
    if (this.moneyAmount <= this.item.total && this.moneyAmount > 0) {
      this.accountService
        .takeMoney(this.item.accountId, this.moneyAmount)
        .subscribe((data) => {
          alert(data)
          this.router.navigate(['account'])
        })
    } else {
      alert('Amount cannot be bigger than total money.')
    }
  }
}
