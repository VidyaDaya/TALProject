import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { async } from '@angular/core/testing';
import { ClientData } from './form/form.component';

@Injectable({
  providedIn: 'root'
})

export class FormService {

  constructor(private http: HttpClient) { }

  calculatePremium = async (clientDetails: ClientData) => {
    return await this.http.post('https://localhost:7268/api/insurancepremium/calculate', clientDetails).toPromise();
    
  }
}
