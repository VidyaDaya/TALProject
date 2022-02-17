import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, NgForm } from '@angular/forms';
import { FormService } from '../form.service';


export interface ClientData {
  fullname: string;
  age: number;
  dateofbirth: string;
  occupation: string;
  deathsuminsured: number;
}

@Component({
  selector: 'app-form',
  templateUrl: './form.component.html',
  styleUrls: ['./form.component.css']
})

export class FormComponent implements OnInit {

  constructor(private formApi: FormService) {}

  ngOnInit(): void {
  }

  insurancePremium: any;

  
  calculatePremium = async (insurancePremiumForm: NgForm) => {
    if (insurancePremiumForm.valid)
    this.insurancePremium = await this.formApi.calculatePremium(insurancePremiumForm.value);
   
   

  }
}
