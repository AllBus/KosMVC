import { Inject, Injectable } from '@angular/core';
import { HttpClient,  HttpErrorResponse} from '@angular/common/http'
import { ConvertResult } from '../models/convert-result'
import { NumberConversionState } from './number-conversion-state';

@Injectable({
  providedIn: 'root'
})
export class NumberConversionService {

  constructor(
    private http: HttpClient, 
    @Inject('BASE_URL') private baseUrl: string
  ) { }

  private state = new NumberConversionState()

  getState():NumberConversionState {
    return this.state
  }

  convertNumberToWords(src: string){
    this.state.loading = true

    const options = { params: {
        'number': src,
      } 
    }

    this.http.get<NumberWordResult>(this.baseUrl+'number/NumberToWords',options)
    .subscribe(
      (data) => {
        this.state.convertResult = new ConvertResult(data.text)
        this.state.loading = false
      },
      (error : HttpErrorResponse) => {
        this.state.convertResult = this.parseError(error)
        this.state.loading = false
      }
    )
    
  }

  convertNumberToDollars(src: string){
    this.state.loading = true

    const options = { params: {
        'number': src,
      } 
    }

    this.http.get<NumberWordResult>(this.baseUrl+'number/NumberToDollars',options)
    .subscribe(
      (data) => {
        this.state.convertResult = new ConvertResult(data.text)
        this.state.loading = false
      },
      (error : HttpErrorResponse) => {
        this.state.convertResult = this.parseError(error)
        this.state.loading = false
      }
    )
  }

  private parseError(error: HttpErrorResponse):ConvertResult{
    let convertResult = new ConvertResult("")
    convertResult.hasResult = false
    switch (error.status) {
      case 400: convertResult.error = "Введите неотрицательное целое число"
        break;
      case 404: convertResult.error = "Запрос к несуществующей странице"
        break;
      case 503: convertResult.error = "Сервер не доступен"
        break;
      default: convertResult.error = "Ошибка обработки данных"
        break;
    }
    return convertResult
  }

}

interface NumberWordResult{
  text: string;

}
