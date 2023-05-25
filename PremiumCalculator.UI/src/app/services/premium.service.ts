import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable, throwError } from 'rxjs';
import { catchError, retry } from 'rxjs/operators';


export class InsuredPerson {
  PersonName!: string;
  Age!: number;
  DateofBirth!: Date;
  OccupationID!: number;
  SumInsured: GLfloat | undefined;
}
 
@Injectable({
  providedIn: 'root'
})
export class PremiumService {
  BaseUrl='https://localhost:7023/api/';
  DeathPremiumUrl = 'Premium/occupations'; 
  occupationUrl = this.BaseUrl+'Premium/occupations'; 
  occupations: any;
  constructor(private http: HttpClient) { }

  calculateDeath(insuredPerson:InsuredPerson ): Observable<any> {
   
    const headers = { 'content-type': 'application/json'}  
    const body=JSON.stringify(insuredPerson);
    return this.occupations = this.http
      .post(this.BaseUrl+'Premium/calculate-death-premium',body,{'headers':headers});
  }

  calculateTPDDeath(insuredPerson:InsuredPerson ): Observable<any> {

    const headers = { 'content-type': 'application/json'}  
    const body=JSON.stringify(insuredPerson);
    return this.occupations = this.http
      .post(this.BaseUrl+'Premium/calculate-tpd-premium',body,{'headers':headers});
  }
}
