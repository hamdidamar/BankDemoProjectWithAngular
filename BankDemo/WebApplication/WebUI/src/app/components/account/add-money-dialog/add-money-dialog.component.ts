import { Component, OnInit } from '@angular/core';
import {NgbModal, ModalDismissReasons} from '@ng-bootstrap/ng-bootstrap';

@Component({
  selector: 'app-add-money-dialog',
  templateUrl: './add-money-dialog.component.html',
  styleUrls: ['./add-money-dialog.component.scss']
})
export class AddMoneyDialogComponent implements OnInit {

  constructor(private modalService: NgbModal) {}


  ngOnInit(): void {
  }
    

}
