import { Injectable } from '@angular/core';
import { HttpClient, HttpResponse } from '@angular/common/http';
import { Observable } from 'rxjs';
import { AnalyzeResponse } from 'src/models/analyze-response';
import { serverUrl } from 'src/global/global-variables';
import { AnalyzeRequest } from 'src/models/analyze-request';

@Injectable({
  providedIn: 'root'
})
export class AnalyzeService {

  constructor(private readonly http: HttpClient) { }

  analyzeText(requestBody: AnalyzeRequest): Observable<HttpResponse<AnalyzeResponse[]>> {
    return this.http.post<AnalyzeResponse[]>(`${serverUrl}analyzetext`, requestBody, { observe: 'response'})
  }

}
