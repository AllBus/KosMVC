import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NumberToWordsFromComponent } from './number-to-words-from/number-to-words-from.component';
import { ResultLabelComponent } from './result-label/result-label.component';

@NgModule({
  declarations: [
    AppComponent,
    NumberToWordsFromComponent,
    ResultLabelComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
    ])
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
