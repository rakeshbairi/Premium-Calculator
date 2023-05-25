import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable, throwError } from 'rxjs';
import { catchError, retry } from 'rxjs/operators';


@Injectable({
  providedIn: 'root'
})
export class OccupationService { 
  BaseUrl='https://localhost:7023/api/';
  occupationUrl = this.BaseUrl+'Premium/occupations'; 
  occupations: any;
  constructor(private http: HttpClient) { }

  getOccupations(): Observable<any> {

    return this.occupations = this.http
      .get(this.occupationUrl);
          
   // return this.http.get<any[]>(this.occupationUrl);
  }
}
