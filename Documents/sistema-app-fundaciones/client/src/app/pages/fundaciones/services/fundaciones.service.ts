import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { MatSnackBar } from '@angular/material/snack-bar';
//import { RolResponse } from '@app/shared/models/rol.interface';
import { FundacionResponse } from '@app/shared/models/fundacion.interface';
import { environment } from '@env/environment';
import { catchError, Observable, throwError } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class FundacionesService {

  constructor(private http: HttpClient, 
    private snackBar: MatSnackBar) { }

    getFundaciones(): Observable<FundacionResponse[]> {
      return this.http.get<FundacionResponse[]>(`${environment.API_URL}/fundaciones`)
      .pipe(catchError( (error) => this.handlerError(error)));
    }

    /*getRoles(): Observable<RolResponse[]> {
      return this.http.get<RolResponse[]>(`${environment.API_URL}/general/roles`)
      .pipe(catchError( (error) => this.handlerError(error) ));
    }*/

    new(fundacion: FundacionResponse): Observable<any> {
      return this.http.post<any>(`${ environment.API_URL }/fundaciones`, fundacion)
      .pipe(catchError( (error) => this.handlerError(error)));
    }

    update(fundacion: FundacionResponse): Observable<any> {
      return this.http.put<any>(`${ environment.API_URL }/fundaciones`, fundacion)
      .pipe(catchError( (error) => this.handlerError(error)));
    }

    delete(cveFundacion: number): Observable<any> {
      return this.http.delete<any>(`${ environment.API_URL }/fundaciones/${cveFundacion}`)
    }

  handlerError(error: any): Observable<never> {
    let errorMessage  = "Ocurrio un error";
    if (error) {
      errorMessage = `${ error.error.message }`;
    }

    this.snackBar.open(errorMessage, '', {
      duration: 5 * 1000,
      panelClass: ['error-snackbar'],
      horizontalPosition: 'right',
      verticalPosition: 'top'
    })

    return throwError(errorMessage);
  }
}
