import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { AnalyzerComponent } from 'src/components/analyzer/analyzer.component';

@NgModule({
  declarations: [
    AppComponent,
    AnalyzerComponent
  ],
  imports: [
    BrowserModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
