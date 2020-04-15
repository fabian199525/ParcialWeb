import { Injectable, Inject } from '@angular/core';
import { Observable } from 'rxjs';
import { tap, catchError } from 'rxjs/operators';
import { HttpClient } from '@angular/common/http';
import { HandleHttpErrorService } from '../@base/handle-http-error.service';
import { Estampilla } from '../estampilla/models/estampilla';

@Injectable({
  providedIn: 'root'
})
export class EstampillaService {

  baseUrl: string;
  constructor(
      private http: HttpClient,
      @Inject('BASE_URL') baseUrl: string,
      private handleErrorService: HandleHttpErrorService)
  {
      this.baseUrl = baseUrl;
  }

  post(estampilla: Estampilla): Observable<Estampilla> {
    return this.http.post<Estampilla>(this.baseUrl + 'api/Persona', estampilla)
    .pipe(
    tap(_ => this.handleErrorService.log('datos enviados')),
    catchError(this.handleErrorService.handleError<Estampilla>('Registrar Persona', null))
    );
   }
   
  
}
